using BiblioTecApi.Controllers;
using BiblioTecApi.Data;
using BiblioTecApi.DTOs;
using BiblioTecApi.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioTecApi.Tests
{
    public class UsuarioControllerTests
    {
        [Fact]
        public void DeveCadastrarUsuario()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("teste")
                .Options;

            var ct = new AppDbContext(options);
            var controller = new UsuarioController(ct);
            UsuarioCadastroDto dto = new UsuarioCadastroDto
            {
                Nome = "teste",
                Email = "teste@email.com",
                Senha = "1234",
                Data_nascimento = new DateTime(2000, 1, 1),
                Celular = "1198764321",
                CursoId = 1,
                Perfil = Perfil.Aluno
            };
            var resultado = controller.CadastroUsuario(dto);
            Assert.IsType<CreatedAtActionResult>(resultado);
            Assert.Single(ct.Usuarios);

        }
    }
}
