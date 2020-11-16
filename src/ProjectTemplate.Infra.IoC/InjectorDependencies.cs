﻿using Microsoft.Extensions.DependencyInjection;
using ProjectTemplate.Application.Interfaces;
using ProjectTemplate.Application.Services;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;
using ProjectTemplate.Domain.Services;
using ProjectTemplate.Infra.Data.Repositories;

namespace ProjectTemplate.Infra.IoC
{
    public static class InjectorDependencies
    {
        public static void Registrer(IServiceCollection services)
        {
            //Application
            services.AddScoped(typeof(IBaseApp<,>), typeof(BaseServicoApp<,>));

            services.AddScoped<IUsuarioApp, UsuarioServicoApp>();
            services.AddScoped<IEdificacoesMoradoresApp, EdificacoesMoradoresServicoApp>();
            services.AddScoped<IEdificacoesApp, EdificacoesServicoApp>();
            services.AddScoped<IPontosEncontroApp, PontosEncontroServicoApp>();

            //Domínio
            services.AddScoped(typeof(IBaseServico<>), typeof(BaseServico<>));

            services.AddScoped<IUsuarioServico, UsuarioServico>();
            services.AddScoped<IEdificacoesMoradoresServico, EdificacoesMoradoresServico>();
            services.AddScoped<IEdificacoesServico, EdificacoesServico>();
            services.AddScoped<IPontosEncontroServico, PontosEncontroServico>();

            //Repositorio
            services.AddScoped(typeof(IBaseRepositorio<>), typeof(BaseRepositorio<>));

            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IEdificacoesMoradoresRepositorio, EdificacoesMoradoresRepositorio>();
            services.AddScoped<IEdificacoesRepositorio, EdificacoesRepositorio>();
            services.AddScoped<IPontosEncontroRepositorio, PontosEncontroRepositorio>();
        }
    }
}
