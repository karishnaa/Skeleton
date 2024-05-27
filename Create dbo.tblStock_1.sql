CREATE PROCEDURE sproc_tblStock_Delete

--this stored procedure is situated in the data layer and is used to delete a single record in the tblStock table.
--it accepts a single parameter @StockID and returns no value

--Declare the parameter
@StockID int

AS 
	--delete the record in the tblStock specified by the value of StockID
	DELETE FROM tblStock WHERE StockID = @StockID;