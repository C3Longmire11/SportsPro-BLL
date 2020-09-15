using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsProDataAccessClassLibrary;

namespace SportsProBusinessClassLibrary
{
    public class IncidentsBL
    {
        IncidentDA incidentsDA = new IncidentDA();

        public IncidentsBL() { }
        public List<RegisteredIncident> GetNoTechIncidents()
        {
            ArrayList IncidentNoTech = new ArrayList();
            List<RegisteredIncident> incidentsNoTechList = new List<RegisteredIncident>();


            try
            {
                IncidentNoTech = incidentsDA.RetriveIncidentsWithNoTech();
                if (IncidentNoTech != null)
                {
                    foreach (object[] row in IncidentNoTech)
                    {
                        RegisteredIncident incidentNoTechData = new RegisteredIncident();
                        incidentNoTechData.CustomerID = Convert.ToInt32(row[0]);
                        incidentNoTechData.CustomerName = Convert.ToString(row[1]);
                        incidentNoTechData.DateOpened = Convert.ToDateTime(row[2]);
                        if (row[3] == DBNull.Value)
                        {
                            incidentNoTechData.DateClosed = null;
                        }
                        else
                        {
                            incidentNoTechData.DateClosed = (DateTime)row[3];
                        }
                        incidentNoTechData.ProductName = Convert.ToString(row[4]);
                        incidentNoTechData.Version = Convert.ToDecimal(row[5]);
                        incidentNoTechData.State = Convert.ToString(row[6]);

                        incidentsNoTechList.Add(incidentNoTechData);
                    }


                }
                return incidentsNoTechList;
            }
                
            
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }


        }

        public List<RegisteredIncident> GetOpenIncidents()
        {
            ArrayList IncidentsOpen = new ArrayList();
            List<RegisteredIncident> incidentsOpenList = new List<RegisteredIncident>();


            try
            {
                IncidentsOpen = incidentsDA.RetriveOpenIncidents();
                if (incidentsOpenList != null)
                {
                    foreach (object[] row in IncidentsOpen)
                    {
                        RegisteredIncident openIncidentsData = new RegisteredIncident();
                        openIncidentsData.CustomerID = Convert.ToInt32(row[0]);
                        openIncidentsData.CustomerName = Convert.ToString(row[1]);
                        openIncidentsData.DateOpened = Convert.ToDateTime(row[2]);
                        if (row[3] == DBNull.Value)
                        {
                            openIncidentsData.DateClosed = null;
                        }
                        else
                        {
                            openIncidentsData.DateClosed = (DateTime)row[3];
                        }
                        openIncidentsData.ProductName = Convert.ToString(row[4]);
                        openIncidentsData.Version = Convert.ToDecimal(row[5]);
                        openIncidentsData.TechName = Convert.ToString(row[6]);
                        openIncidentsData.TechEmail = Convert.ToString(row[7]);
                        openIncidentsData.TechPhone = Convert.ToString(row[8]);
                        openIncidentsData.State = Convert.ToString(row[9]);

                        incidentsOpenList.Add(openIncidentsData);
                    }

                    
                }
                return incidentsOpenList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public List<RegisteredIncident> GetClosedIncidents()
        {
            ArrayList IncidentsClosed = new ArrayList();
            List<RegisteredIncident> incidentsClosedRecord = new List<RegisteredIncident>();


            try
            {
                IncidentsClosed = incidentsDA.RetriveClosedIncidents();
                if (incidentsClosedRecord != null)
                {
                    foreach (object[] row in IncidentsClosed)
                    {
                        RegisteredIncident closedIncidentsData = new RegisteredIncident();
                        closedIncidentsData.CustomerID = Convert.ToInt32(row[0]);
                        closedIncidentsData.CustomerName = Convert.ToString(row[1]);
                        closedIncidentsData.DateOpened = Convert.ToDateTime(row[2]);
                        closedIncidentsData.DateClosed = Convert.ToDateTime(row[3]);
                        closedIncidentsData.ProductName = Convert.ToString(row[4]);
                        closedIncidentsData.Version = Convert.ToDecimal(row[5]);
                        closedIncidentsData.TechName = Convert.ToString(row[6]);
                        closedIncidentsData.TechEmail = Convert.ToString(row[7]);
                        closedIncidentsData.TechPhone = Convert.ToString(row[8]);
                        closedIncidentsData.State = Convert.ToString(row[9]);

                        incidentsClosedRecord.Add(closedIncidentsData);
                    }

                    return incidentsClosedRecord;
                }

                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

    }
}
