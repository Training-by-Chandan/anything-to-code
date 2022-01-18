alter procedure sp_CreateStudentParent @studentName nvarchar(50), @fatherName nvarchar(50), @motherName nvarchar(50)
as
begin
	--if ISNULL(@studentName,'')!='' and ISNULL(@fatherName,'')!='' and ISNULL(@motherName,'')!=''
	--begin
	begin tran t1;
	begin try

		--create student
		insert into student (name) values (@studentName)
		declare @studentId int = scope_identity()

		--create father 
		insert into Parent (name, Type) values (@fatherName,0)
		declare @fatherId int =scope_identity()

		--create mother 
		insert into Parent (name, Type) values (@motherName,1)
		declare @motherId int =scope_identity()

		--maintain the relation between student and parent
		insert into SP (StudentId, ParentId) values 
		(@studentId, @fatherId),
		(@studentId,@motherId)

		commit tran t1;
	end try
	begin catch
		print error_message()
		rollback tran t1
	end catch
	--end
	--else
	--begin
	--	print 'There are some errors in the parameters '
	--end

end
