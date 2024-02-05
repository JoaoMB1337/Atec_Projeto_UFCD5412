# Sistema de Gestão de Ativos da ADOSMELHORES

## Descrição

Este programa em C# foi desenvolvido para atender às necessidades de gestão de ativos da ADOSMELHORES, uma empresa de formação. A aplicação fornece funcionalidades para gerenciar informações sobre funcionários, diretores, secretárias, formadores e coordenadores. O programa utiliza classes e herança para organizar e realizar as tarefas especificadas.

## Classes

1. **Funcionario**
   - Representa informações genéricas sobre um funcionário.
   - Atributos: `ID`, `nome`, `morada`, `contacto`, `dataFimContrato`, `dataRegistoCriminal`.

2. **Diretor**
   - Representa um diretor na empresa.
   - Herda de Funcionario.
   - Atributos adicionais: `isencaoHorario`, `bonusMensal`, `carroEmpresa`.

3. **Secretaria**
   - Representa uma secretária na empresa.
   - Herda de Funcionario.
   - Atributos adicionais: `diretorReportado`, `area`.

4. **Formador**
   - Representa um formador na empresa.
   - Herda de Funcionario.
   - Atributos adicionais: `areaLecionada`, `disponibilidade`, `valorHora`.

5. **Coordenador**
   - Representa um coordenador na empresa.
   - Herda de Funcionario.
   - Atributos adicionais: `formadoresAssociados` (lista de formadores).

## Recursos Adicionais

- Validação para garantir a integridade dos dados.
- Flexibilidade nas opções de disponibilidade para formadores (pós-laboral, laboral ou ambas).
- Informações sobre o diretor reportado e a área para secretárias.
- Lista de formadores associados para coordenadores.

## Como Usar

1. Compile e execute o programa em C#.
2. Siga o menu na tela para realizar diferentes ações relacionadas à gestão de ativos.
3. Após cada ação, o programa retorna ao menu inicial.

## Licença

Este programa é distribuído sob a Licença MIT, concedendo aos usuários a liberdade de usar, modificar e distribuir o software. Contribuições são bem-vindas por meio de issues ou pull requests.

## Agradecimentos

Agradecemos por considerar contribuir para o desenvolvimento deste Sistema de Gestão de Ativos. Sua colaboração é essencial para o sucesso desta aplicação.
