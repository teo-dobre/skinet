﻿using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CouponsController(ICouponService couponService) : BaseApiController
{
    [HttpGet("{code}")]
    public async Task<ActionResult<AppCoupon>> ValidateCoupon(string code)
    {
        var coupon = await couponService.GetCouponFromPromoCode(code);

        if (coupon != null)
        {
            return coupon;
        }

        return BadRequest("Invalid coupon");
    }
}
