create table tbl_responses
(
	resp_id uniqueidentifier primary key,
	name varchar(255),
	email varchar(255),
	mobile varchar(15),
	subject varchar(255),
	msg text
)

select * from tbl_responses