using Application.Features.ProgrammingLanguages.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Brands.Models;

public class ProgrammingLanguageListModel : BasePageableModel
{
    public IList<ProgrammingLanguageListDto> Items { get; set; }
}