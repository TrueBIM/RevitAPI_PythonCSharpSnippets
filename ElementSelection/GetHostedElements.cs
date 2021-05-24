IList<Element> SelectElementByIdNumber(Document doc)
{
  FilteredElementCollector collector = new Autodesk.Revit.DB.FilteredElementCollector(doc);
  collector.OfClass(typeof(Autodesk.Revit.DB.FamilyInstance));
  collector.Cast<Autodesk.Revit.DB.FamilyInstance>();
  collector.Where(e => e.Host as Autodesk.Revit.DB.HostObject != null);
  collector.ToList();
  return collector
}
