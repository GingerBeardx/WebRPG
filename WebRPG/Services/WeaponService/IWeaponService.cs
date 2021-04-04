using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRPG.DTOs.Character;
using WebRPG.DTOs.Weapon;
using WebRPG.Models;

namespace WebRPG.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
