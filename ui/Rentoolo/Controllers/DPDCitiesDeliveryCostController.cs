﻿using Rentoolo.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Rentoolo.Controllers
{
    public class DPDCitiesDeliveryCostController : ApiController
    {
        private readonly DPDCalc.DPDCalculatorClient _calcClient;
        public DPDCitiesDeliveryCostController()
        {
            _calcClient = new DPDCalc.DPDCalculatorClient();
        }
        [HttpPost]
        public IHttpActionResult Index([FromBody]DPDCalcRequestModel request)
        {
            try
            {
                var deliveryCity = GeographyDPDHelper.GetDPDCitiesTop10(request.DeliveryCityName);
                var pickupCity = GeographyDPDHelper.GetDPDCitiesTop10(request.PickupCityName);

                var serviceCosts = _calcClient.getServiceCost2(new DPDCalc.serviceCostRequest()
                {
                    auth = new DPDCalc.auth()
                    {
                        clientKey = request.ClientKey,
                        clientNumber = request.ClientNumber
                    },
                    delivery = new DPDCalc.cityRequest()
                    {
                        cityId = deliveryCity.FirstOrDefault().cityId,
                        cityIdSpecified = true,
                    },
                    pickup = new DPDCalc.cityRequest()
                    {
                        cityId = pickupCity.FirstOrDefault().cityId,
                        cityIdSpecified = true,
                    },
                    declaredValue = request.DeclaredValue,
                    selfDelivery = request.SelfDelivery,
                    selfPickup = request.SelfPickup,
                    weight = request.Weight
                });

                return Json(serviceCosts);
            }
            catch(Exception exc)
            {
                return Json(exc.Message);
            }
            
        }
    }
}