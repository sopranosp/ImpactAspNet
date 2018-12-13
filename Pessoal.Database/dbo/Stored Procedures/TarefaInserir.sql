﻿
CREATE PROCEDURE TarefaInserir
   
    @nome           nvarchar(200),
	@prioridade     tinyint,
	@concluida       bit, 
	@observacoes     nvarchar(1000)  
AS
INSERT INTO [dbo].[Tarefa]
           ([Nome]
           ,[Prioridade]
           ,[Concluida]
           ,[Observacoes])

     output inserted.id
     VALUES
       (  @Nome          
	    , @prioridade    
	    ,@concluida  
	    , @observacoes      )
