﻿ALTER TABLE [dbo].[MachineDepartments]
    ADD CONSTRAINT [MachineDepartment_FK01] FOREIGN KEY ([MachineId]) REFERENCES [dbo].[Machines] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION;

