USE [Efinance]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 11/10/2021 01:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidade](
	[CidadeId] [int] IDENTITY(1,1) NOT NULL,
	[UfId] [int] NOT NULL,
	[NomeCidade] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[CidadeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/10/2021 01:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[CpfCnpj] [nvarchar](14) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[NomeFantasia] [nvarchar](50) NOT NULL,
	[RazaoSocial] [nvarchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
	[CidadeId] [int] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uf]    Script Date: 11/10/2021 01:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uf](
	[UfId] [int] IDENTITY(1,1) NOT NULL,
	[CodigoIBGE] [varchar](2) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Sigla] [varchar](2) NOT NULL,
	[CodigoBacen] [varchar](20) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Uf] PRIMARY KEY CLUSTERED 
(
	[UfId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Uf] ADD  CONSTRAINT [DF_Table_1_C005_CodigoBacen]  DEFAULT ('') FOR [CodigoBacen]
GO
ALTER TABLE [dbo].[Uf] ADD  CONSTRAINT [DF_Table_1_C005_NomePais]  DEFAULT ('') FOR [Pais]
GO
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_Cidade_Uf] FOREIGN KEY([UfId])
REFERENCES [dbo].[Uf] ([UfId])
GO
ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_Cidade_Uf]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cidade] FOREIGN KEY([CidadeId])
REFERENCES [dbo].[Cidade] ([CidadeId])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cidade]
GO
/****** Object:  StoredProcedure [dbo].[dp_GetAllUf]    Script Date: 11/10/2021 01:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vandair
-- Create date: 10/10/2021
-- Description:	Retorna lista de estados
-- =============================================
CREATE PROCEDURE [dbo].[dp_GetAllUf] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [UfId]
      ,[CodigoIBGE]
      ,[Estado]
      ,[Sigla]
      ,[CodigoBacen]
      ,[Pais]
  FROM [dbo].[Uf]
END
GO
