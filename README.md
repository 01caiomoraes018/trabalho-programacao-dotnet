# Trabalho 1 - Programação Aplicada em .NET

Exercícios de Console em C#, baseados nas aulas do professor Lucas Teodoro dos Santos.

## Exercícios

- Questão 1: biblioteca com herança e Pattern Matching. Demonstra os sete resultados previstos, incluindo os limites de 3 empréstimos para alunos e 5 para professores.
- Questão 2: Reflection aberta exibe as seis propriedades de Equipamento. A controlada exibe somente Nome, Fabricante, Valor e Localizacao, marcadas com [Exibir].

- Questão 3: reserva de hotel com DTO definido por record. Mapear calcula o total das diárias e ExibirRelatorio apresenta somente os dados do relatório, sem os campos internos da reserva.

Requisito: SDK .NET 9. Execute um exercício por vez:

```sh
dotnet run --project Questao1-Biblioteca
dotnet run --project Questao2-Reflection
dotnet run --project Questao3-ReservaHotel
```

As três questões estão implementadas. No exemplo da reserva, 3 diárias de R$ 180,00 totalizam R$ 540,00.

Referência: [código das aulas](https://github.com/teodorolucaas/ProgramacaoAplicadaDotNet). Os exemplos de PatternMatching foram adaptados para usuários da biblioteca e os de Reflection_Attributes para equipamentos. A questão 3 adapta os exemplos de DTO e Imutabilidade para o Console.
