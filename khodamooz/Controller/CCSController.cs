using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pis.data.automation.entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using pis.data.ccs.entities;

namespace pis
{
    [Route("api/[controller]")]
    public class CCSController : Controller
    {
        private readonly CCSContext _context;

        public CCSController(CCSContext context)
        {
            _context = context;
        }

        // [HttpPost("GetReceiptsContainers")]
        // //[Authorize(Policy = "TransportCorps")]
        // public IActionResult GetReceiptsContainers([FromBody] string[] receiptsNoString)
        // {
        //   var checkIfReceiptExist= _context.Receipt.Where(r=>receiptsNoString.Contains(r.ReceiptNumber)).Select(r=>r.ReceiptNumber).ToList();
        //   if(checkIfReceiptExist.Count==0)  return NotFound("قبض انباری با این مشخصات وجود ندارد");

        //   var checkReceiptVlidationQuery= _context.Receipt.Where(r=>receiptsNoString.Contains(r.ReceiptNumber) && r.Status==49).Select(r=>r.ReceiptNumber);


        //   var query = (from Receipt in _context.Receipt
        //                join Blcontainer in _context.Blcontainer on Receipt.Blid equals Blcontainer.Blid
        //                join Container in _context.Container on Blcontainer.ContainerId equals Container.ContainerId
        //                where receiptsNoString.Contains(Receipt.ReceiptNumber) && Receipt.Status!=49
        //                select new {
        //                  ShomarehGhabzAnbar=Receipt.ReceiptNumber,
        //                  ShomarehContainer=Container.ContainerNumber,
        //                  VaznNakhales = Container.GrossWeight,
        //                  PorYaKhali=Container.FullEmpty,
        //                  ISOContainerCode= Container.IsocontainerCode,
        //                  VaznContainer= Container.TareWeight,
        //                  ShomarehPolomb = Container.SealNumber,
        //                  KhatKeshtirani = Container.Owner,
        //                  NamayandegiKeshtirani = Container.Agent
        //                }).ToList();

        //   if (query.Count > 0)
        //   {
        //     return Ok(query);
        //   }
        //   return NotFound("قبض انباری با این مشخصات وجود ندارد");
        // }

        [HttpGet("GetReceiptContainers/{receiptNumber}")]
        //[Authorize(Policy = "TransportCorps")]
        public IActionResult GetReceiptContainers(string receiptNumber)
        {
            var checkIfReceiptExist = _context.Receipt.Where(r => r.ReceiptNumber == receiptNumber).Select(r => r.ReceiptNumber).ToList();
            if (checkIfReceiptExist.Count == 0) return NotFound("قبض انباری با این شماره وجود ندارد");

            var checkReceiptVlidationQuery = _context.Receipt.Where(r => r.ReceiptNumber == receiptNumber && r.Status == 49).Select(r => r.ReceiptNumber).ToList();
            if (checkReceiptVlidationQuery.Count > 0) return NotFound("این قبض انبار غیرفعال و نامعتبر می باشد");

            var query = (from Receipt in _context.Receipt
                         join Blcontainer in _context.Blcontainer on Receipt.Blid equals Blcontainer.Blid
                         join Container in _context.Container on Blcontainer.ContainerId equals Container.ContainerId
                         where Receipt.ReceiptNumber == receiptNumber && Receipt.Status == 51
                         select new
                         {
                             ShomarehGhabzAnbar = Receipt.ReceiptNumber,
                             ShomarehContainer = Container.ContainerNumber,
                             VaznNakhales = Container.GrossWeight,
                             PorYaKhali = (bool)Container.FullEmpty ? "پر" : "خالی",
                             ISOContainerCode = Container.IsocontainerCode,
                             VaznContainer = Container.TareWeight,
                             ShomarehPolomb = Container.SealNumber,
                             KhatKeshtirani = Container.Owner,
                             NamayandegiKeshtirani = Container.Agent
                         }).ToList();

            if (query.Count > 0)
            {
                return Ok(query);
            }
            return NotFound("قبض انباری با این شماره وجود ندارد");
        }
    }
}
