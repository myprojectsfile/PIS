using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pis.data.automation.entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace pis
{
  [Route("api/[controller]")]
  public class AutomationController : Controller
  {
    private readonly eOrganizationContext _context;

    public AutomationController(eOrganizationContext contex)
    {
      _context = contex;
    }

    [HttpGet("GetLetterFlow/{barcodeNo}")]
    [AllowAnonymous]
    public IActionResult GetLetterFlow(string barcodeNo)
    {
      var query = (from Rel_Entity_Indicator in _context.RelEntityIndicator
                  join Sends in _context.Sends
                        on new { ETC = Rel_Entity_Indicator.Etc, FEC = Rel_Entity_Indicator.Fec }
                  equals new { ETC = Sends.EntityTypeCode, FEC = Sends.EntityCode }

                  join Roles in _context.Roles on Sends.SenderRoleId equals Roles.RoleId
                  join Users in _context.Users on new { UserID = Convert.ToInt32(Roles.UserId) } equals new { UserID = Users.UserId }
                  join Send_Receivers in _context.SendReceivers on Sends.SendCode equals Send_Receivers.SendCode
                  join Actions in _context.Actions on new { ActionCode = Convert.ToInt32(Send_Receivers.ActionCode) } equals new { ActionCode = Actions.ActionCode }
                  join Roles_1 in _context.Roles on new { ReceiverRoleID = Send_Receivers.ReceiverRoleId } equals new { ReceiverRoleID = Roles_1.RoleId }
                  join Users_1 in _context.Users on new { UserID = Convert.ToInt32(Roles_1.UserId) } equals new { UserID = Users_1.UserId }
                  where
                    Rel_Entity_Indicator.Etc == 619 &&
                    Rel_Entity_Indicator.Id.ToString() == barcodeNo
                   select new
                  {
                    Barcode = Rel_Entity_Indicator.Id,
                    Password = Rel_Entity_Indicator.FollowPassword,
                    RaveshDaryaft = Rel_Entity_Indicator.ImportMethod,
                    shomarehSabtVaredeh= Rel_Entity_Indicator.ImportEntityNumber,
                    ShomarehAvaliehMadrak = Rel_Entity_Indicator.ImportOriginNo,
                    TarikhAvaliehMadrak = Rel_Entity_Indicator.ImportOriginDate,
                    MozoeMadrak = Rel_Entity_Indicator.DocSubject,
                    FerestandehSemat = Roles.RoleName,
                    FerestandehName = Users.FirstName,
                    FerestandehFamil = Users.LastName,
                    OnvanFerestandehNameh = Rel_Entity_Indicator.From,
                    TarikhSabtVaredeh = Rel_Entity_Indicator.ImportDate,
                    PeyvastDarad = Rel_Entity_Indicator.NopgAttached,
                    NoeAmaliat = Actions.ActionName,
                    GirandehName = Users_1.FirstName,
                    GirandehFamil = Users_1.LastName,
                    GirandehSemat = Roles_1.RoleName,
                    TarikhErja = Sends.SendDate,
                    TarikhPasokh = Send_Receivers.ResponseDate
                  }).ToList();

      if (query.Count>0)
      {
        return Ok(query);
      }
      return NotFound("نامه ای با این مشخصات ثبت نگردیده است");
    }
  }
}
