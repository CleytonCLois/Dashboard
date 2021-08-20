using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDashboard.Shared
{
    public enum ISituacaoPrefeitura
    {
        AtualizadoHoje = 1, //1 - Atualizado HOJE
        Atualizado24hrs = 2, //2 - Atualizado nas últimas 24h
        Desatualizado = 3, //3 - Desatualizado
        DesatualizadoMaisDeUmaSemanada = 4, //4 - Desatualizado a mais de 1 semana
        Tudo = -1
    }
}
