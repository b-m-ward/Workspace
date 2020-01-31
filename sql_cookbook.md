## Get % complete of DB restore
```
SELECT command, percent_complete,total_elapsed_time, estimated_completion_time, start_time
FROM sys.dm_exec_requests
WHERE command IN ('RESTORE DATABASE')
```

## Get last run queries from a DB
```
SELECT execquery.last_execution_time AS [Date Time], execsql.text AS [Script] FROM sys.dm_exec_query_stats AS execquery
CROSS APPLY sys.dm_exec_sql_text(execquery.sql_handle) AS execsql
ORDER BY execquery.last_execution_time DESC
```
