﻿namespace CRUD.Core.Application.DTOs.Department
{
    public class SaveDepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
