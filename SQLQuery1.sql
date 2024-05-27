USE [p2714644]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStock_Count_GroupByPrice]

SELECT	@return_value as 'Return Value'

GO
