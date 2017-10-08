using System;

namespace DataTransferObjectWithTypedDataSet
{
    /// <summary>
    /// An assembler class maps the actual database calls into typed dataset. Client of assembler does not know about existence
    /// or communication with database.
    /// RecordingDto is our DTO object here. Since it is a TypedDataSet object, it offers following benefit-
    /// 1. It works like a development tool support.
    /// 2. Integrates well with controls.
    /// 3. Supports serialization.
    /// 4. Provides a disconnected database model.
    /// 5. No need of casting the data since type declaration sort of takes place during the design time.
    ///
    /// </summary>
    class Assembler
    {
        public static RecordingDto CreateRecordingDto(long id)
        {
            string selectCmd = String.Format("select * from recording where id = {0}", id);

            //Open connection here.
            //Fill up command object here using DTO.

            //Create the dto here...
            RecordingDto dto = new RecordingDto();
            
            //Call command.Fill to load data here...

            return dto;
        }
    }
}
