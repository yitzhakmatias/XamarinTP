﻿using System;
using System.Collections.Generic;
using System.Reflection;
using BL.Core.Services.Model;
using Foundation;
using SVG.Forms.Plugin.Abstractions;
using UIKit;

namespace SiteHandsTP.DataSources
{
    public class CountryDataSource : UITableViewSource
    {

        private readonly List<Country> _getCountries;
        readonly NSString _cellIdentifier = new NSString("CountryCell");

        public CountryDataSource(List<Country> getCountries, UITableViewController controllers)
        {
            _getCountries = getCountries;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(_cellIdentifier) ?? new UITableViewCell(UITableViewCellStyle.Default, _cellIdentifier);

            var country = _getCountries[indexPath.Row];

            cell.TextLabel.Text = country.Name +" "+ country.Region ;

           // cell.ImageView.Image = UIImage.FromBundle(country.Flag);
           
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _getCountries.Count;
        }

        public Country GetItem(int id)
        {
            return _getCountries[id];
        }
       
    }
  
}