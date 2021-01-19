-- criação da tabela
CREATE TABLE [dbo].[CategoryRule](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[MinValue] [float] NULL,
	[MaxValue] [float] NULL,
	[ClientSector] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- populando a tabela com algumas categorias
Insert into CategoryRule values('LOWRISK',0, 1000000 , 'Public')
Insert into CategoryRule values('MEDIUMRISK',1000000, CAST('1.79E+308' AS float) , 'Public')
Insert into CategoryRule values('HIGHRISK',1000000, CAST('1.79E+308' AS float) , 'Private')
GO

--criando a procedure para retornar a categoria
CREATE PROCEDURE [dbo].[spr_GetTradeCategory] 
	         @Amount as float,
             @ClientSector as varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT c.Name
			From CategoryRule c
		where ClientSector = @ClientSector
			and c.MinValue < @Amount
			and c.MaxValue > @Amount
END
GO

--executando teste 
exec [dbo].[spr_GetTradeCategory] 2000000,'Private'
exec [dbo].[spr_GetTradeCategory] 400000,'Public'
exec [dbo].[spr_GetTradeCategory] 500000,'Public'
exec [dbo].[spr_GetTradeCategory] 3000000,'Public'
