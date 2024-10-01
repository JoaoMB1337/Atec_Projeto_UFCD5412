# ADOSMELHORES Asset Management System

## Descrição

Este programa em C# foi desenvolvido para atender às necessidades de gestão de ativos da ADOSMELHORES, uma empresa de treinamento. A aplicação fornece funcionalidades para gerenciar informações sobre funcionários, diretores, secretários, formadores e coordenadores. O programa utiliza classes e herança para organizar e realizar as tarefas especificadas.

## Classes

### Employee
- Representa informações genéricas sobre um funcionário.
- **Atributos**: ID, nome, endereço, contato, data de término do contrato, data de registro criminal.

### Director
- Representa um diretor na empresa.
- **Herda de**: Employee.
- **Atributos adicionais**: isenção de horário, bônus mensal, carro da empresa.

### Secretary
- Representa um secretário na empresa.
- **Herda de**: Employee.
- **Atributos adicionais**: diretor reportado, área.

### Trainer
- Representa um formador na empresa.
- **Herda de**: Employee.
- **Atributos adicionais**: área ensinada, disponibilidade, taxa horária.

### Coordinator
- Representa um coordenador na empresa.
- **Herda de**: Employee.
- **Atributos adicionais**: formadores associados (lista de formadores).

## Funcionalidades Adicionais

- Validação para garantir a integridade dos dados.
- Flexibilidade nas opções de disponibilidade dos formadores (pós-laboral, laboral ou ambos).
- Informações sobre o diretor reportado e a área para secretários.
- Lista de formadores associados para coordenadores.

## Como Usar

1. Compile e execute o programa em C#.
2. Siga o menu na tela para realizar diferentes ações relacionadas à gestão de ativos.
3. Após cada ação, o programa retorna ao menu inicial.

## Licença

Este programa é distribuído sob a licença MIT, concedendo aos usuários a liberdade de usar, modificar e distribuir o software. Contribuições são bem-vindas através de issues ou pull requests.

## Agradecimentos

Agradecemos sua consideração em contribuir para o desenvolvimento deste Sistema de Gestão de Ativos. Sua colaboração é essencial para o sucesso desta aplicação.
