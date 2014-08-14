﻿ALTER TABLE [dbo].[MachineDepartments]
    ADD CONSTRAINT [aaaaaMachineDepartment_PK] PRIMARY KEY NONCLUSTERED ([MachineId] ASC, [DepartmentId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

