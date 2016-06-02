using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginRegistrationSrvc" in both code and config file together.
[ServiceContract]
public interface ILoginRegistrationSrvc
{
    [OperationContract]
    int LoginVenue(string userName, string password);

    [OperationContract]
    bool RegisterVenue(Venue v, VenueLogin vl);

    [OperationContract]
    bool NewShow(Show s, ShowDetail sd, string artistName);

    [OperationContract]
    bool NewShowDetail(ShowDetail sd, int showKey, string artistName);

    [OperationContract]
    int NewArtist(Artist artist);
}
