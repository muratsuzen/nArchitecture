using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;
using System.Xml.Linq;

namespace Application.Features.ProgrammingLanguages.Rules;

public class ProgrammingLanguageBusinessRules
{
    private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

    public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
    {
        _programmingLanguageRepository = programmingLanguageRepository;
    }

    public async Task ProgrammingLanguageNameCanNotBeDuplicatedWhenInserted(string name)
    {
        IPaginate<ProgrammingLanguage> result = await _programmingLanguageRepository.GetListAsync(b => b.Name == name);
        if (result.Items.Any()) throw new BusinessException("ProgrammingLanguage name exists.");
    }

    public async Task ProgrammingLanguageNameCanNotEmpty(string name)
    {
        
        if (string.IsNullOrEmpty(name)) throw new BusinessException("ProgrammingLanguage name can not empty.");
    }

    public async Task ProgrammingLanguageNameCanNotBeDuplicatedWhenUpdated(int id,string name)
    {
        IPaginate<ProgrammingLanguage> result =
            await _programmingLanguageRepository.GetListAsync(b => b.Name == name && b.Id != id);
        if (result.Items.Any()) throw new BusinessException("ProgrammingLanguage name exists.");
    }

    public async Task ProgrammingLanguageIdCanNotEmpty(int id)
    {

        if (id == 0) throw new BusinessException("ProgrammingLanguage id can not empty.");
    }

    public async Task ProgrammingLanguageIdIsExists(int id)
    {
        ProgrammingLanguage result =
            await _programmingLanguageRepository.GetAsync(b => b.Id == id);
        if (result == null) throw new BusinessException($"ProgrammingLanguage {id} id data not found!");
    }
}