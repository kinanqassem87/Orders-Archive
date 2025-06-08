using Columbus_Order.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Columbus_Order.BL
{
    class ClassDocument
    {
        public static int AddDoc(string DocType, string DocOwn, string DocNum, DateTime DocDate, string Doc_note)
        {
            DataAccessLayerA.Open();
            int i = DataAccessLayerA.ExecuteNonQuery("AddDoc", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@Doc_Type", SqlDbType.NVarChar, DocType),
                DataAccessLayerA.CreateParameter("@Doc_Own", SqlDbType.NVarChar, DocOwn),
                DataAccessLayerA.CreateParameter("@Doc_number", SqlDbType.NVarChar, DocNum),
                DataAccessLayerA.CreateParameter("@Doc_Date", SqlDbType.Date, DocDate),
                DataAccessLayerA.CreateParameter("@Doc_Note", SqlDbType.NVarChar, Doc_note));
            DataAccessLayerA.Close();
            return i;
        }
        public static DataTable SelectLastDoc()
        {
            DataAccessLayerA.Open();
            DataTable dt = DataAccessLayerA.ExecuteTable("SelectLastDoc", CommandType.StoredProcedure);
            DataAccessLayerA.Close();
            return dt;
        }
        public static int AddDocImage(byte[] arr, int id)
        {
            DataAccessLayerA.Open();
            int i = DataAccessLayerA.ExecuteNonQuery("AddDocImage", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@Doc_Img", SqlDbType.Image, arr),
                DataAccessLayerA.CreateParameter("@Doc_id", SqlDbType.Int, id));
            DataAccessLayerA.Close();
            return i;
        }
        public static DataTable selectAllDoc()
        {
            DataAccessLayerA.Open();
            DataTable dt = DataAccessLayerA.ExecuteTable("selectAllDoc", CommandType.StoredProcedure);
            DataAccessLayerA.Close();
            return dt;
        }
        public static DataTable searchForDoc(string search)
        {
            DataAccessLayerA.Open();
            DataTable dt = DataAccessLayerA.ExecuteTable("searchForDoc", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayerA.Close();
            return dt;
        }
        public static int updateDocDetails(int id, string docType, string docOwn, string docnumber, DateTime docDate, string docnote)
        {
            DataAccessLayerA.Open();
            int i = DataAccessLayerA.ExecuteNonQuery("updateDocDetails", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@Doc_id", SqlDbType.Int, id),
                DataAccessLayerA.CreateParameter("@Doc_Type", SqlDbType.NVarChar, docType),
                DataAccessLayerA.CreateParameter("@Doc_Own", SqlDbType.NVarChar, docOwn),
                DataAccessLayerA.CreateParameter("@Doc_number", SqlDbType.NVarChar, docnumber),
                DataAccessLayerA.CreateParameter("@Doc_Date", SqlDbType.Date, docDate),
                DataAccessLayerA.CreateParameter("@Doc_Note", SqlDbType.NVarChar, docnote));
            DataAccessLayerA.Close();
            return i;
        }
        public static int DeleteDoc(int id)
        {
            DataAccessLayerA.Open();
            int i = DataAccessLayerA.ExecuteNonQuery("DeleteDoc", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@Doc_id", SqlDbType.Int, id));
            DataAccessLayerA.Close();
            return i;
        }
        public static int DeleteImgWithDelDoc(int id)
        {
            DataAccessLayerA.Open();
            int i = DataAccessLayerA.ExecuteNonQuery("DeleteImgWithDelDoc", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@Doc_id", SqlDbType.Int, id));
            DataAccessLayerA.Close();
            return i;
        }
        public static DataTable selectImgForOneDoc(int id)
        {
            DataAccessLayerA.Open();
            DataTable dt = DataAccessLayerA.ExecuteTable("selectImgForOneDoc", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@DocID", SqlDbType.Int, id));
            DataAccessLayerA.Close();
            return dt;
        }
        public static int insertImgToDoc(byte[] arr, int DocId)
        {
            DataAccessLayerA.Open();
            int i = DataAccessLayerA.ExecuteNonQuery("insertImgToDoc", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@Doc_Img", SqlDbType.Image, arr),
                DataAccessLayerA.CreateParameter("@Doc_id", SqlDbType.Int, DocId));
            DataAccessLayerA.Close();
            return i;
        }
        public static int DeleteImg(int ImgId)
        {
            DataAccessLayerA.Open();
            int i = DataAccessLayerA.ExecuteNonQuery("DeleteImg", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@Doc_Img_ID", SqlDbType.Int, ImgId));
            DataAccessLayerA.Close();
            return i;
        }
        public static DataTable SearchAfterDate(DateTime search)
        {
            DataAccessLayerA.Open();
            DataTable dt = DataAccessLayerA.ExecuteTable("SearchAfterDate", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@search", SqlDbType.Date, search));
            DataAccessLayerA.Close();
            return dt;
        }

        public static DataTable SearchBeforDate(DateTime search)
        {
            DataAccessLayerA.Open();
            DataTable dt = DataAccessLayerA.ExecuteTable("SearchBeforDate", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@search", SqlDbType.Date, search));
            DataAccessLayerA.Close();
            return dt;
        }

        public static DataTable SearchEqualDate(DateTime search)
        {
            DataAccessLayerA.Open();
            DataTable dt = DataAccessLayerA.ExecuteTable("SearchEqualDate", CommandType.StoredProcedure,
                DataAccessLayerA.CreateParameter("@search", SqlDbType.Date, search));
            DataAccessLayerA.Close();
            return dt;
        }
    }
}
