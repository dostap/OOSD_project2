/* Package class
 * Author: Hazem Hegazy
 * Date: Jul-2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Package
/// </summary>
public class Package
{
    //constructor
    public Package() { }

    //declare public properties
    public int PackageId { get; set; }
    public string PkgName { get; set; }
    public string PkgDesc { get; set; }
    public DateTime PkgStartDate { get; set; }
    public DateTime PkgEndDate { get; set; }
    public decimal PkgBasePrice { get; set; }
    public decimal PkgAgencyCommission { get; set; }

}