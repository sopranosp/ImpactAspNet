

CREATE PROCEDURE  TarefaAtualizar
 
    
    @nome           nvarchar(200),
	@prioridade     tinyint,
	@concluida       bit, 
	@observacoes     nvarchar(1000)  
AS
update     [dbo].[Tarefa]

set 
            [Nome] = @Nome    
           ,[Prioridade] = @prioridade 
           ,[Concluida] = @concluida
           ,[Observacoes] = @observacoes 





