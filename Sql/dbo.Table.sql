CREATE TABLE [dbo].[new_book]
(
	[bid] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [bname] VARCHAR(50) NOT NULL, 
    [bauthor] VARCHAR(50) NOT NULL, 
    [bpubl] VARCHAR(50) NOT NULL, 
    [bpdate] VARCHAR(50) NOT NULL, 
    [bprice] BIGINT NOT NULL, 
    [bquan] BIGINT NOT NULL
)
