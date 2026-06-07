# 🖊️ Projeto CRUD de Gestão de Canetas - .NET MAUI

![Status do Projeto](https://img.shields.io/badge/Status-Conclu%C3%ADdo-brightgreen)
![Plataforma](https://img.shields.io/badge/Platform-Android%20%7C%20Windows-blue)
![Framework](https://img.shields.io/badge/Framework-.NET%20MAUI-purple)

Este projeto foi desenvolvido como parte da **Prova Regimental (A1)** da disciplina de **Programação Para Dispositivos Móveis (PDM)** no **Centro Universitário do DF (UDF)**. 

O objetivo principal do aplicativo é realizar o gerenciamento de um estoque de canetas, permitindo as operações básicas de um sistema CRUD (Create, Read, Update e Delete) utilizando persistência de dados local.

---

## 🚀 Funcionalidades

O app **Prova Regimental** permite:
- **Cadastrar**: Adicionar novas canetas informando o fabricante e a cor.
- **Listar**: Visualizar todas as canetas cadastradas em tempo real com atualização automática.
- **Editar**: Alterar as informações de uma caneta já existente.
- **Excluir**: Remover registros do banco de dados de forma definitiva.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/)
- **Banco de Dados:** SQLite (via biblioteca `sqlite-net-pcl`)
- **Marcação de Interface:** XAML
- **Arquitetura:** Padrão MVVM simplificado (DAL, Model e Views)

---

## 📁 Estrutura do Projeto

Seguindo as diretrizes da prova, o projeto está organizado nas seguintes camadas:

- **Model**: Contém a classe `Caneta.cs`, que define a estrutura da tabela no banco de dados.
- **DAL (Data Access Layer)**: Contém a classe `crudSQLite.cs`, responsável por toda a lógica de conexão e comandos SQL (Insert, Select, Update, Delete).
- **Views**: Contém as telas do aplicativo:
  - `TelaListaCaneta.xaml`: Listagem geral.
  - `TelaIncluirCaneta.xaml`: Formulário de cadastro.
  - `TelaAlterarCaneta.xaml`: Tela de edição e exclusão.
- **Resources**: Pasta contendo os ícones customizados, Splash Screen e imagens de fundo.

---

## 📱 Demonstração da Interface

O aplicativo conta com uma interface personalizada:
- **Ícone Customizado**: Ícone de caneta configurado para Android e Windows.
- **Splash Screen**: Tela de carregamento personalizada com a logo do projeto.
- **Design:** Uso de imagens de fundo (`fundocaneta.png`) e botões estilizados para melhor usabilidade.

---

## ⚙️ Como executar o projeto

1. Tenha o **Visual Studio 2022** (ou superior) instalado com a carga de trabalho do .NET MAUI.
2. Clone este repositório:
   ```bash
   git clone https://github.com/SEU_USUARIO/appProvaA1Caneta.git
