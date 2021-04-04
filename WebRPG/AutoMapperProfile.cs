using AutoMapper;
using System.Linq;
using WebRPG.DTOs.Character;
using WebRPG.DTOs.Skill;
using WebRPG.DTOs.Weapon;
using WebRPG.Models;

namespace WebRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}
