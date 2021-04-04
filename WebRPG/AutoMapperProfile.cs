using AutoMapper;
using WebRPG.DTOs.Character;
using WebRPG.DTOs.Weapon;
using WebRPG.Models;

namespace WebRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
    }
}
