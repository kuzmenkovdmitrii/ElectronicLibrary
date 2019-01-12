sqlcmd -S.\SQLEXPRESS -E -i %CreateDBScript.sql


sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateAdvertising.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectRandomAdvertisingByCountStoredProcedure.sql


PAUSE