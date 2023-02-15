CREATE DATABASE [BdMeusLivros]
GO
USE BdMeusLivros

CREATE TABLE [dbo].[TabelaLogin](
	[usuario] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[TabelaLivros](
	[nome] [varchar](50) NOT NULL,
	[ano] [date] NOT NULL,
	[autor] [varchar](50) NOT NULL, 
	[editora] [varchar](50) NOT NULL,
	[datacadastro] [date] NOT NULL,
	[observacoes] [varchar](50) NOT NULL
) ON [PRIMARY]

INSERT INTO TabelaLogin values ('admin', 'admin')