$fn = 400;

SEGMENTS = 8;
ANGLE = 360 / (SEGMENTS + 0.5);

rotate([90,0,0]) difference() {
    translate([0,0,-1]) cylinder(h=1,r=1);
    cylinder(h=3,r=0.8, center=true);
    rotate([0,0,-ANGLE/2]) translate([0,-5,-5]) cube(10);
    rotate([0,0,ANGLE/2]) mirror([1,0,0]) translate([0,-5,-5]) cube(10);
}
