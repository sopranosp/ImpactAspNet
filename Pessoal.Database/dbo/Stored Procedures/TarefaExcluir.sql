


CREATE PROCEDURE TarefaExcluir
    @Id int
   
AS
    Delete
	from Tarefa 
WHERE Id=@ID




RETURN 0 