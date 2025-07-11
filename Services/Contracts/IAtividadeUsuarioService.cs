﻿using SistemaCadastroDeHorasApi.Models;
using SistemaCadastroDeHorasApi.Models.DTO;

namespace SistemaCadastroDeHorasApi.Services.Contracts;

public interface IAtividadeUsuarioService
{

    Task<IEnumerable<ResAtividadeUsario>> GetAllByUserMatriculaAsync(int matriucla);
    Task AddAsync(Atividades atividade, int matricula, IFormFile comprovante);
    Task<string> UpdateAsync(ReqUpdateAtividadeDTO dto, Guid atividadeId);
    Task DeleteByAtividadeIdAsync(Guid id);
}