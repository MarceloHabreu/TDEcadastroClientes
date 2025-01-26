# TDE: Cadastro de Clientes em C#

Este projeto foi desenvolvido como parte de uma **TDE (Trabalho Dirigido de Estudos)** durante o **2º período** da faculdade. O objetivo principal era implementar um sistema simples de cadastro de clientes utilizando a linguagem **C#** e a biblioteca de interface gráfica **Windows Forms**. Este foi meu primeiro contato com C# e com o Windows Forms, o que tornou a experiência um marco no aprendizado de desenvolvimento de aplicações desktop.

---

## 📂 Estrutura do Projeto

O sistema é focado em um **CRUD completo** (Create, Read, Update, Delete) para gerenciar os dados de clientes. Os atributos utilizados no projeto são:

```csharp
// Atributos
public int Id { get; set; }
public string Nome { get; set; }
public int Idade { get; set; }
public string Endereco { get; set; }
public string Telefone { get; set; }
public string Email { get; set; }
```

---

## 🔧 Tecnologias e Conceitos Utilizados

- **C#**: Linguagem principal utilizada para o desenvolvimento.
- **Windows Forms**: Biblioteca de interface gráfica para criar a aplicação desktop.
- **POO (Programação Orientada a Objetos)**:
  - Classes e objetos para representação dos clientes.
  - Encapsulamento para proteção dos dados.
- **CRUD**: Implementação das operações de criação, leitura, atualização e exclusão de clientes.

---

## 🚀 Como Executar

1. Certifique-se de ter o **Visual Studio** instalado em seu computador.
2. Clone o repositório:

```bash
git clone https://github.com/MarceloHabreu/TDE-CadastroClientes.git
```

3. Abra o projeto no Visual Studio e compile o código.
4. Execute o projeto pressionando `F5` ou clicando no botão de "Start".

---

## 🌟 Funcionalidades

- 📝 Cadastro de novos clientes.
- 🔍 Visualização de todos os clientes cadastrados em uma tabela.
- ✏️ Atualização dos dados de clientes.
- ❌ Exclusão de registros.

---

## 📜 Licença

Este projeto é livre para uso e modificação. Fique à vontade para explorar e personalizá-lo conforme suas necessidades.

