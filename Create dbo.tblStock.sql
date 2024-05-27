CREATE PROCEDURE sproc_tblStock_Update
--create parameters for the stored procedure
@StockID int,
@StockName varchar (50),
@Price float,
@Quantity int,
@Available bit,
@Description varchar (50),
@ArrivalDate date

AS
	--update the record as specified by the @stockID value
	UPDATE tblStock
	SET
	StockName = @StockName ,
	Price = @Price ,
	Quantity = @Quantity ,
	Available = @Available ,
	Description = @Description ,
	ArrivalDate = @ArrivalDate 

	WHERE StockID = @StockID

