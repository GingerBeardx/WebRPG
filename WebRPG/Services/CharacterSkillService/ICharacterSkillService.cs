using System.Threading.Tasks;
using WebRPG.DTOs.Character;
using WebRPG.DTOs.CharacterSkill;
using WebRPG.Models;

namespace WebRPG.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}
