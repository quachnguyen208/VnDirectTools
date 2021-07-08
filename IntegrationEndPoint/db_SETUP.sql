USE VAS
ALTER DATABASE VAS SET COMPATIBILITY_LEVEL = 130
CREATE TABLE BI_FinanceInfor(ID  int IDENTITY(1,1)
,[Symbol] nvarchar(20)
,[Result] nvarchar(max))
;
CREATE PROC sp_BI_FinanceInfor_Create

@Symbol nvarchar(20) = ''
,@Result nvarchar(max) = ''
as
begin
INSERT INTO BI_FinanceInfor(Symbol,Result)
select @Symbol,@Result
end

--exec sp_FinanceInfor_Get 'STB'
;

create proc sp_FinanceInfor_Get

@symbol  nvarchar(3) = 'HNG'
,@json nvarchar(max) = ''
,@list nvarchar(max) = ''
,@c_value nvarchar(max) = ''
,@result1 nvarchar(max) = ''
,@result2 nvarchar(max) = ''
,@result3 nvarchar(max) = ''

as

begin 

SET @json = (select top 1 [Result] from BI_FinanceInfor where Symbol = @symbol order by ID desc)
SET @list = (SELECT [value] from openjson(@json) as [Finance]
where Finance.[key] = 1);

with cte as (select ROW_NUMBER() OVER (ORDER BY [value] ASC) AS ROWID, [value] --into #temp 
from openjson(@list,'$') as [list] ) 
SELECT * into #temp1 FROM cte c where c.[ROWID] = 1
;
with cte as (select ROW_NUMBER() OVER (ORDER BY [value] ASC) AS ROWID, [value] --into #temp 
from openjson(@list,'$') as [list] ) 
SELECT * into #temp2 FROM cte c where c.[ROWID] = 2
;
with cte as (select ROW_NUMBER() OVER (ORDER BY [value] ASC) AS ROWID, [value] --into #temp 
from openjson(@list,'$') as [list] ) 
SELECT * into #temp3 FROM cte c where c.[ROWID] = 3

SET @result1 = (select [value] from #temp1)
SET @result2 = (select [value] from #temp2)
SET @result3 = (select [value] from #temp3)

select * from openjson(@result1,'$') with (
[ID] [nvarchar](150) '$.ID',
	[ReportNormID] [nvarchar](150) '$.ReportNormID',
	[Name] [nvarchar](150) '$.Name' ,
	[NameEn] [nvarchar](150) '$.NameEn',
	[NameMobile] [nvarchar](150) '$.NameMobile',
	[NameMobileEn] [nvarchar](150) '$.NameMobileEn',
	[CssStyle] [nvarchar](150) '$.CssStyle',
	[Padding] [nvarchar](150) '$.Padding',
	[ParentReportNormID] [nvarchar](150) '$.ParentReportNormID' ,
	[ReportComponentName] [nvarchar](150) '$.ReportComponentName',
	[ReportComponentNameEn] [nvarchar](150) '$.ReportComponentNameEn',
	[Unit] [nvarchar](150) '$.Unit',
	[UnitEn] [nvarchar](150) '$.UnitEn',
	[OrderType] [nvarchar](150) '$.OrderType',
	[OrderingComponent] [nvarchar](150) '$.OrderingComponent',
	[RowNumber] [nvarchar](150) '$.RowNumber',
	[ReportComponentTypeID] [nvarchar](150) '$.ReportComponentTypeID',
	[ChildTotal] [nvarchar](150) '$.ChildTotal',
	[Levels] [nvarchar](150) '$.Levels',
	[Value1] [decimal](18, 0) '$.Value1',
	[Value2] [decimal](18, 0) '$.Value2',
	[Value3] [decimal](18, 0) '$.Value3',
	[Value4] [decimal](18, 0) '$.Value4'
) as t
UNION ALL
select * from openjson(@result2,'$') with(
[ID] [nvarchar](150) '$.ID',
	[ReportNormID] [nvarchar](150) '$.ReportNormID',
	[Name] [nvarchar](150) '$.Name' ,
	[NameEn] [nvarchar](150) '$.NameEn',
	[NameMobile] [nvarchar](150) '$.NameMobile',
	[NameMobileEn] [nvarchar](150) '$.NameMobileEn',
	[CssStyle] [nvarchar](150) '$.CssStyle',
	[Padding] [nvarchar](150) '$.Padding',
	[ParentReportNormID] [nvarchar](150) '$.ParentReportNormID' ,
	[ReportComponentName] [nvarchar](150) '$.ReportComponentName',
	[ReportComponentNameEn] [nvarchar](150) '$.ReportComponentNameEn',
	[Unit] [nvarchar](150) '$.Unit',
	[UnitEn] [nvarchar](150) '$.UnitEn',
	[OrderType] [nvarchar](150) '$.OrderType',
	[OrderingComponent] [nvarchar](150) '$.OrderingComponent',
	[RowNumber] [nvarchar](150) '$.RowNumber',
	[ReportComponentTypeID] [nvarchar](150) '$.ReportComponentTypeID',
	[ChildTotal] [nvarchar](150) '$.ChildTotal',
	[Levels] [nvarchar](150) '$.Levels',
	[Value1] [decimal](18, 0) '$.Value1',
	[Value2] [decimal](18, 0) '$.Value2',
	[Value3] [decimal](18, 0) '$.Value3',
	[Value4] [decimal](18, 0) '$.Value4'
) as t
UNION ALL
select * from openjson(@result3,'$') with(
[ID] [nvarchar](150) '$.ID',
	[ReportNormID] [nvarchar](150) '$.ReportNormID',
	[Name] [nvarchar](150) '$.Name' ,
	[NameEn] [nvarchar](150) '$.NameEn',
	[NameMobile] [nvarchar](150) '$.NameMobile',
	[NameMobileEn] [nvarchar](150) '$.NameMobileEn',
	[CssStyle] [nvarchar](150) '$.CssStyle',
	[Padding] [nvarchar](150) '$.Padding',
	[ParentReportNormID] [nvarchar](150) '$.ParentReportNormID' ,
	[ReportComponentName] [nvarchar](150) '$.ReportComponentName',
	[ReportComponentNameEn] [nvarchar](150) '$.ReportComponentNameEn',
	[Unit] [nvarchar](150) '$.Unit',
	[UnitEn] [nvarchar](150) '$.UnitEn',
	[OrderType] [nvarchar](150) '$.OrderType',
	[OrderingComponent] [nvarchar](150) '$.OrderingComponent',
	[RowNumber] [nvarchar](150) '$.RowNumber',
	[ReportComponentTypeID] [nvarchar](150) '$.ReportComponentTypeID',
	[ChildTotal] [nvarchar](150) '$.ChildTotal',
	[Levels] [nvarchar](150) '$.Levels',
	[Value1] [decimal](18, 0) '$.Value1',
	[Value2] [decimal](18, 0) '$.Value2',
	[Value3] [decimal](18, 0) '$.Value3',
	[Value4] [decimal](18, 0) '$.Value4'
) as t
end