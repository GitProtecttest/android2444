@echo on

set olderthan=10
set source="C:\Users\Michal\Downloads"
set destination="C:\New folder"

:: /E  Copies directories and subdirectories, including empty ones
:: /Po0  Suppresses warning on file-overwrite (Legacy /Y)
:: /DB#  Copies files that were changed on or before  days ago.
xxcopy %source% %destination% /E /Po0 /DB#%olderthan%