using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAppPetrol.Domain.Response;
using ApiAppPetrol.Exceptions;
using ApiAppPetrol.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
//

namespace ApiAppPetrol.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly PetrolSDContext _context;

        public VehicleService(PetrolSDContext context){
            _context = context;
        }
        public async Task<VechileResponse> GetVehicleData(Guid QRcode)
        {
            var VehicleData= await _context.Mvehicle
            .Where(vdata => vdata.QrCode == QRcode)
            .Include(vdata => vdata.MvehicleCard)
            // .Where(vdata => vdata.DateModified.Value.Date.Year >= DateTime.Now.Date.Year )
            .Select(vdata => new VechileResponse{
                VehicleId = vdata.VehicleId,
                ProfileName = vdata.Profile.ProfileName,
                StatusName = vdata.Status.StatusName,
                MarkName =vdata.Mark.MarkName,
                ModelName = vdata.Model.ModelName,
                ChassisNum = vdata.ChassisNum,
                FuelName = vdata.Fuel.FuelName,
                FuelTypeName = vdata.FuelType.FuelTypeName,
                PlateChar =vdata.PlateChar,
                PlateNumber=vdata.PlateNumber,
                ManufaDate = vdata.ManufaDate,
                StatusId = vdata.StatusId,
                TankCapacity = vdata.TankCapacity,
                vehicleCard = vdata.MvehicleCard.Select(card => new VehicleCard{
                        DateAdded = card.DateAdded,
                        ExpDate = card.ExpDate,
                        UserAdded = card.UserAdded
                }).OrderByDescending(card => card.ExpDate).FirstOrDefault(),
                
            })
            .FirstOrDefaultAsync();
            
            return VehicleData;
        }
    }

}