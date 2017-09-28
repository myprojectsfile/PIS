export default {
    "Routes": [
        {
            "routeUrl": "/home",
            "claims": []
        },
        {
            "routeUrl": "/profile",
            "claims": [
                "SuperAdmin"
            ]
        },
        {
            "routeUrl": "/profile/profilePhoto",
            "claims": [
                "SuperUser"
            ]
        }
    ]
}