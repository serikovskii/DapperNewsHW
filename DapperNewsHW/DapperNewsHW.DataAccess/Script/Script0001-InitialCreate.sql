Create table [dbo].[Articles]
(
	Id uniqueidentifier not null primary key,
	Theme nvarchar(max) not null,
	Text nvarchar(max) not null,
	DateArticle datetime2 not null
)

Create table [dbo].[Comment]
(
	Id uniqueidentifier not null primary key,
	NameCommentary nvarchar(max) not null,
	Commentary nvarchar(max) not null,
	DateCommentary datetime2 not null,
	ArticleId uniqueidentifier not null,
	Foreign key (ArticleId) references Articles(Id)
)

