DataBase table editor
===
Editor connects to any database after authorization. The user can perform any actions with tables
in the corresponding database.There is no need to update anything in the editor, as the program 
updates everything dynamically.

> The editor accepts:
text types: nchar, nvarchar, nchar, nvarchar, ntext, text;
integer types: bigint, int, smallint, tinyint, bit;
real types: float;
date/time types: smalldatetime, datetime, datetime2, date

> At each user input field, the input data is checked for 
correctness, and in case of an error, a message is displayed 
to the user

> The function of changing date/time type values has not been 
finalized in the program, but all this can be implemented by 
deleting and adding rows/columns.
