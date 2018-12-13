CREATE PROCEDURE TarefaSelecionar
    @Id int =null
   
AS
    SELECT A.Id, 
	       A.NOME,
	       A.Concluida,
		   A.Prioridade,
		   A.Observacoes
	from Tarefa A WITH(NOLOCK) 
WHERE Id=ISNULL(@ID,ID)

ORDER BY A.Id


RETURN 0 