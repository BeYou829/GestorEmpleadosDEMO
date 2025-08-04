namespace CRUD.Helpers
{
    public static class DataTableHelpers
    {
        public static  int? GetSelectedId(DataGridView dataTable)
        {
            try
            {
                var id = int.Parse(dataTable.Rows[dataTable.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
