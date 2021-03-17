USE [CustomerData]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[updateCustomer]
@firstName nvarchar(30),
@id int
as
begin
update Customers set Firstname = @firstName where CustomerID = @id
end
GO