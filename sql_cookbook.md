## Get % complete of DB restore
```
SELECT command, percent_complete,total_elapsed_time, estimated_completion_time, start_time
FROM sys.dm_exec_requests
WHERE command IN ('RESTORE DATABASE')
```
