CREATE function FormateaconCeros (@num int,@cuantosCeros int) returns
nvarchar(100)
as
begin
return right(replicate('0',@cuantosceros)+cast(@num as
nvarchar(100)),@cuantosCeros)
end