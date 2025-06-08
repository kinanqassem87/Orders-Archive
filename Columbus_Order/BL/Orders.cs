using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Columbus_Order.DAL;

namespace Columbus_Order.BL
{
    class Orders
    {
        public static DataTable sp_SelectAllUser()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_SelectAllUser", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable lastOrderId()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("lastOrderId", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int InsertOrder(DateTime Create_Date,string Order_NumOfPic, string Client_Name, string Order_Desc, 
            string Order_Follower, DateTime Dead_Line,string Order_State,string Print_Emp,
            string Order_Cut,string Order_Print,string Order_Emp,string Order_Barcode,string Order_Season)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("InsertOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Create_Date", SqlDbType.Date, Create_Date),
                DataAccessLayer.CreateParameter("@Order_NumOfPic", SqlDbType.NVarChar, Order_NumOfPic),
                DataAccessLayer.CreateParameter("@Client_Name", SqlDbType.NVarChar, Client_Name),
                DataAccessLayer.CreateParameter("@Order_Desc", SqlDbType.NVarChar, Order_Desc),
                DataAccessLayer.CreateParameter("@Order_Follower", SqlDbType.NVarChar, Order_Follower),
                DataAccessLayer.CreateParameter("@Dead_Line", SqlDbType.Date, Dead_Line),
                DataAccessLayer.CreateParameter("@Order_State", SqlDbType.NVarChar, Order_State),
                DataAccessLayer.CreateParameter("@Print_Emp", SqlDbType.NVarChar, Print_Emp),
                DataAccessLayer.CreateParameter("@Order_Cut", SqlDbType.NVarChar, Order_Cut),
                DataAccessLayer.CreateParameter("@Order_Print", SqlDbType.NVarChar, Order_Print),
                DataAccessLayer.CreateParameter("@Order_Emp", SqlDbType.NVarChar, Order_Emp),
                DataAccessLayer.CreateParameter("@Order_Barcode", SqlDbType.NVarChar, Order_Barcode),
                DataAccessLayer.CreateParameter("@Order_Season", SqlDbType.NVarChar, Order_Season));
            DataAccessLayer.Close();
            return i;
        }

        public static int InsertImg(byte[] arr, int id,string ImgType)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("InsertImg", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Img_Doc", SqlDbType.Image, arr),
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@ImgType", SqlDbType.NVarChar, ImgType));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectOrderView()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderView", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable SelectOrderViewC()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderViewC", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SelectOrderViewP()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderViewP", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SelectOrderViewE()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderViewE", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SelectOrderViewCManag()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderViewCManag", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SelectOrderViewPManag()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderViewPManag", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SelectOrderViewEManag()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderViewEManag", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }




        public static DataTable selectImgForOneDoc(int OrderId)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectImgForOneDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderId));
            DataAccessLayer.Close();
            return dt;
        }

        public static int DeleteImg(int ImgId)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteImg", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Img_Id", SqlDbType.Int, ImgId));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectOrderArchive()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderArchive", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SelectAllOrder()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllOrder", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectImgForOneDocOrders(int OrderId,string imgType)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectImgForOneDocOrders", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderId),
                DataAccessLayer.CreateParameter("@ImgType", SqlDbType.NVarChar, imgType));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchOrderArchive(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchOrderArchive", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.NVarChar, Search));
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable SearchAllOrder(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchAllOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.NVarChar, Search));
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable SearchOrderView(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchOrderView", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.NVarChar, Search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateOrder(int orderId, DateTime Create_Date,string Order_NumOfPic, string Client_Name, string Order_Desc,
            string Order_Follower, DateTime Dead_Line, string Order_State,
            string Print_Emp,string Order_Print,string Order_Emp, string Order_Barcode, string Order_Season)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, orderId),
                DataAccessLayer.CreateParameter("@Create_Date", SqlDbType.Date, Create_Date),
                DataAccessLayer.CreateParameter("@Order_NumOfPic", SqlDbType.NVarChar, Order_NumOfPic),
                DataAccessLayer.CreateParameter("@Client_Name", SqlDbType.NVarChar, Client_Name),
                DataAccessLayer.CreateParameter("@Order_Desc", SqlDbType.NVarChar, Order_Desc),
                DataAccessLayer.CreateParameter("@Order_Follower", SqlDbType.NVarChar, Order_Follower),
                DataAccessLayer.CreateParameter("@Dead_Line", SqlDbType.Date, Dead_Line),
                DataAccessLayer.CreateParameter("@Order_State", SqlDbType.NVarChar, Order_State),
                DataAccessLayer.CreateParameter("@Print_Emp", SqlDbType.NVarChar, Print_Emp),
                DataAccessLayer.CreateParameter("@Order_Print", SqlDbType.NVarChar, Order_Print),
                DataAccessLayer.CreateParameter("@Order_Emp", SqlDbType.NVarChar, Order_Emp),
                DataAccessLayer.CreateParameter("@Order_Barcode", SqlDbType.NVarChar, Order_Barcode),
                DataAccessLayer.CreateParameter("@Order_Season", SqlDbType.NVarChar, Order_Season));
            DataAccessLayer.Close();
            return i;
        }

        public static int deleteImgOrder(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteImgOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int deleteOrder(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateDoneOrder(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateDoneOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateDoneOrderC(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateDoneOrderC", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateDoneOrderP(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateDoneOrderP", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateDoneOrderE(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateDoneOrderE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateToUnDone(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateToUnDone", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateToUnDoneC(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateToUnDoneC", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateToUnDoneP(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateToUnDoneP", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }
        public static int updateToUnDoneE(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateToUnDoneE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }



        public static int UpdateImgOrder(int id,byte[] arr)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateImgOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Img_Id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@Img_Doc", SqlDbType.Image, arr));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectRowPendingOrder()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectRowPendingOrder", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateRowMaterialState(int Order_Id, string RowMatrialState)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateRowMaterialState", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@RowMatrialState", SqlDbType.NVarChar, RowMatrialState));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectRowDoneOrder()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectRowDoneOrder", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SelectGeneralOrderInfo()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectGeneralOrderInfo", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int InsertDeptState(string SweingState, string TasfiaState, string TasleemState, string RowMatrialState, int Order_Id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("InsertDeptState", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SweingState", SqlDbType.NVarChar, SweingState),
                DataAccessLayer.CreateParameter("@TasfiaState", SqlDbType.NVarChar, TasfiaState),
                DataAccessLayer.CreateParameter("@TasleemState", SqlDbType.NVarChar, TasleemState),
                DataAccessLayer.CreateParameter("@RowMatrialState", SqlDbType.NVarChar, RowMatrialState),
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectVersion()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectVersion", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int AddCat(string CatName)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddCat", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CatName", SqlDbType.NVarChar, CatName));
            DataAccessLayer.Close();
            return i;
        }
        public static int AddCol(string ColName)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddCol", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ColName", SqlDbType.NVarChar, ColName));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SelectAllCat()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectAllCat", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int UpdateCat(int CatID, string CatName)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateCat", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CatID", SqlDbType.Int, CatID),
                DataAccessLayer.CreateParameter("@CatName", SqlDbType.NVarChar, CatName));
            DataAccessLayer.Close();
            return i;
        }
        public static int DeleteCat(int CatID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteCat", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CatID", SqlDbType.Int, CatID));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SelectAllCol()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectAllCol", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int UpdateCol(int ColID, string ColName)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateCol", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ColID", SqlDbType.Int, ColID),
                DataAccessLayer.CreateParameter("@ColName", SqlDbType.NVarChar, ColName));
            DataAccessLayer.Close();
            return i;
        }
        public static int DeleteCol(int ColID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteCol", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ColID", SqlDbType.Int, ColID));
            DataAccessLayer.Close();
            return i;
        }
        public static int InsertNewOrder(DateTime Create_Date, string Order_NumOfPic, string Client_Name, string Order_Desc,
            string Order_Follower, DateTime Dead_Line, string Order_State, string Print_Emp,
            string Order_Cut, string Order_Print, string Order_Emp, string Order_Barcode, string Order_Season,
            string OrderSex,int CatID,int ColID,string Production_Num,DateTime Production_Date,string ReadyPro,string Tafseel,string Print_One,string Tatreez,string Print_Two)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("InsertNewOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Create_Date", SqlDbType.Date, Create_Date),
                DataAccessLayer.CreateParameter("@Order_NumOfPic", SqlDbType.NVarChar, Order_NumOfPic),
                DataAccessLayer.CreateParameter("@Client_Name", SqlDbType.NVarChar, Client_Name),
                DataAccessLayer.CreateParameter("@Order_Desc", SqlDbType.NVarChar, Order_Desc),
                DataAccessLayer.CreateParameter("@Order_Follower", SqlDbType.NVarChar, Order_Follower),
                DataAccessLayer.CreateParameter("@Dead_Line", SqlDbType.Date, Dead_Line),
                DataAccessLayer.CreateParameter("@Order_State", SqlDbType.NVarChar, Order_State),
                DataAccessLayer.CreateParameter("@Print_Emp", SqlDbType.NVarChar, Print_Emp),
                DataAccessLayer.CreateParameter("@Order_Cut", SqlDbType.NVarChar, Order_Cut),
                DataAccessLayer.CreateParameter("@Order_Print", SqlDbType.NVarChar, Order_Print),
                DataAccessLayer.CreateParameter("@Order_Emp", SqlDbType.NVarChar, Order_Emp),
                DataAccessLayer.CreateParameter("@Order_Barcode", SqlDbType.NVarChar, Order_Barcode),
                DataAccessLayer.CreateParameter("@Order_Season", SqlDbType.NVarChar, Order_Season),
                DataAccessLayer.CreateParameter("@OrderSex", SqlDbType.NVarChar,OrderSex),
                DataAccessLayer.CreateParameter("@CatID", SqlDbType.Int,CatID),
                DataAccessLayer.CreateParameter("@ColID", SqlDbType.Int,ColID),
                DataAccessLayer.CreateParameter("@Production_Num", SqlDbType.NVarChar,Production_Num),
                DataAccessLayer.CreateParameter("@Production_Date", SqlDbType.Date,Production_Date),
                DataAccessLayer.CreateParameter("@ReadyPro", SqlDbType.NVarChar, ReadyPro),
                DataAccessLayer.CreateParameter("@Tafseel", SqlDbType.NVarChar, Tafseel),
                DataAccessLayer.CreateParameter("@Print_One", SqlDbType.NVarChar, Print_One),
                DataAccessLayer.CreateParameter("@Tatreez", SqlDbType.NVarChar, Tatreez),
                DataAccessLayer.CreateParameter("@Print_Two", SqlDbType.NVarChar, Print_Two));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SelectOrderViewNew()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderViewNew", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectOneOrder (int Order_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectOneOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int updateTafseel(int Order_Id,string Tafseel)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateTafseel", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Tafseel", SqlDbType.NVarChar, Tafseel));
            DataAccessLayer.Close();
            return i;
        }
        public static int updatePrint_One(int Order_Id, string Print_One)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updatePrint_One", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Print_One", SqlDbType.NVarChar, Print_One));
            DataAccessLayer.Close();
            return i;
        }
        public static int updateTatreez(int Order_Id, string Tatreez)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateTatreez", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Tatreez", SqlDbType.NVarChar, Tatreez));
            DataAccessLayer.Close();
            return i;
        }
        public static int updateSewing(int Order_Id, string Sewing)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateSewing", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Sewing", SqlDbType.NVarChar, Sewing));
            DataAccessLayer.Close();
            return i;
        }
        public static int updatePrint_Two(int Order_Id, string Print_Two)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updatePrint_Two", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Print_Two", SqlDbType.NVarChar, Print_Two));
            DataAccessLayer.Close();
            return i;
        }
        public static int updateTasfia(int Order_Id, string Tasfia)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateTasfia", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Tasfia", SqlDbType.NVarChar, Tasfia));
            DataAccessLayer.Close();
            return i;
        }
        public static int UpdateProNumberDate(int Order_Id, string Production_Num, DateTime Production_Date)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateProNumberDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Production_Num", SqlDbType.NVarChar, Production_Num),
                DataAccessLayer.CreateParameter("@Production_Date", SqlDbType.Date, Production_Date));
            DataAccessLayer.Close();
            return i;
        }
        public static int Update_Col_Cat(int Order_Id, int Col_Id,int Cat_Id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("Update_Col_Cat", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@CatID", SqlDbType.Int, Cat_Id),
                DataAccessLayer.CreateParameter("@ColID", SqlDbType.Int, Col_Id));
            DataAccessLayer.Close();
            return i;
        }
        public static int UpdateNewOrder(int Order_Id,string Order_NumOfPic, string Client_Name, string Order_Desc,
            string Order_Follower, DateTime Dead_Line,string Print_Emp,
            string Order_Cut, string Order_Print, string Order_Emp, string Order_Barcode, string Order_Season,
            string OrderSex, int CatID, int ColID,string ReadyPro, string Tafseel, string Print_One, string Tatreez, string Print_Two)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateNewOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id),
                DataAccessLayer.CreateParameter("@Order_NumOfPic", SqlDbType.NVarChar, Order_NumOfPic),
                DataAccessLayer.CreateParameter("@Client_Name", SqlDbType.NVarChar, Client_Name),
                DataAccessLayer.CreateParameter("@Order_Desc", SqlDbType.NVarChar, Order_Desc),
                DataAccessLayer.CreateParameter("@Order_Follower", SqlDbType.NVarChar, Order_Follower),
                DataAccessLayer.CreateParameter("@Dead_Line", SqlDbType.Date, Dead_Line),
                DataAccessLayer.CreateParameter("@Print_Emp", SqlDbType.NVarChar, Print_Emp),
                DataAccessLayer.CreateParameter("@Order_Cut", SqlDbType.NVarChar, Order_Cut),
                DataAccessLayer.CreateParameter("@Order_Print", SqlDbType.NVarChar, Order_Print),
                DataAccessLayer.CreateParameter("@Order_Emp", SqlDbType.NVarChar, Order_Emp),
                DataAccessLayer.CreateParameter("@Order_Barcode", SqlDbType.NVarChar, Order_Barcode),
                DataAccessLayer.CreateParameter("@Order_Season", SqlDbType.NVarChar, Order_Season),
                DataAccessLayer.CreateParameter("@OrderSex", SqlDbType.NVarChar, OrderSex),
                DataAccessLayer.CreateParameter("@CatID", SqlDbType.Int, CatID),
                DataAccessLayer.CreateParameter("@ColID", SqlDbType.Int, ColID),
                DataAccessLayer.CreateParameter("@ReadyPro", SqlDbType.NVarChar, ReadyPro),
                DataAccessLayer.CreateParameter("@Tafseel", SqlDbType.NVarChar, Tafseel),
                DataAccessLayer.CreateParameter("@Print_One", SqlDbType.NVarChar, Print_One),
                DataAccessLayer.CreateParameter("@Tatreez", SqlDbType.NVarChar, Tatreez),
                DataAccessLayer.CreateParameter("@Print_Two", SqlDbType.NVarChar, Print_Two));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectOrdersByCat(int CatID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrdersByCat", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CatID", SqlDbType.Int, CatID));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SelectOrdersByCol(int ColID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrdersByCol", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ColID", SqlDbType.Int, ColID));
            DataAccessLayer.Close();
            return dt;
        }


    }
}
