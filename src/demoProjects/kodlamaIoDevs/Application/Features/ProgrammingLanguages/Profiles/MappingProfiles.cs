using Application.Features.Brands.Models;
using Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Dtos;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ProgrammingLanguage, CreatedProgrammingLanguageDto>().ReverseMap();
        CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();
        CreateMap<IPaginate<ProgrammingLanguage>, ProgrammingLanguageListModel>().ReverseMap();
        CreateMap<ProgrammingLanguage, ProgrammingLanguageListDto>().ReverseMap();
        CreateMap<ProgrammingLanguage, ProgrammingLanguageGetByIdDto>().ReverseMap();
    }
}