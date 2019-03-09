﻿namespace Network {
	public enum MessageType {
		AssignID = 0,
		ClientRequestObjectSync = 10,
		ServerRequestObjectSync = 11,
		ServerRequestObjectSyncComplete = 12,
		Instantiate = 20,
		SyncTransform = 30
	}
}