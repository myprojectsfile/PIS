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

    [HttpPost("GetReceiptsContainers")]
    //[Authorize(Policy = "TransportCorps")]
    public IActionResult GetReceiptsContainers([FromBody] string[] receiptsNoString)
    {
      var query = (from Containers in _context.Container
                   join ReceiptContainers in _context.ReceiptContainer on Containers.ContainerId equals ReceiptContainers.ContainerId
                   where receiptsNoString.Contains(ReceiptContainers.ReceiptNumber)
                   //where ReceiptContainers.ReceiptNumber== receiptsNoString
                   select new {
                     ShomarehGhabzAnbar=ReceiptContainers.ReceiptNumber,
                     ShomarehContainer=Containers.ContainerNumber,
                     VaznNakhales = Containers.GrossWeight,
                     PorYaKhali=Containers.FullEmpty,
                     ISOContainerCode= Containers.IsocontainerCode,
                     VaznContainer= Containers.TareWeight,
                     ShomarehPolomb = Containers.SealNumber,
                     KhatKeshtirani = Containers.Owner,
                     NamayandegiKeshtirani = Containers.Agent,
                     SahebGhabz = ReceiptContainers.Consignee
                   }).ToList();

      if (query.Count > 0)
      {
        return Ok(query);
      }
      return NotFound("قبض انباری با این مشخصات وجود ندارد");
    }
  }
}
