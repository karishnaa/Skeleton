CREATE PROCEDURE sproc_tblStock_FilterByStockID
	--parameter to store the stock id we are looking for
	@StockID int
AS
	--select all fields from the table where the stock id matches the parameters
	SELECT * FROM tblStock WHERE StockID = @StockID
RETURN 0
