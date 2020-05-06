public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        string destinationCity = "";
        HashSet<string> cities = new HashSet<string>();
        for(int i = 0; i < paths.Count; i++){
            if(!cities.Contains(paths[i][0])){
                cities.Add(paths[i][0]);
            }
        }
        
        for(int j = 0; j < paths.Count; j++){
            if(cities.Contains(paths[j][1])){
                cities.Remove(paths[j][1]);
            }else{
                cities.Add(paths[j][1]);
            }
        }
        
        for(int m = 0; m < paths.Count; m++){
            if(cities.Contains(paths[m][1])){
                destinationCity = paths[m][1];
            }
        }
        return destinationCity;
    }
}