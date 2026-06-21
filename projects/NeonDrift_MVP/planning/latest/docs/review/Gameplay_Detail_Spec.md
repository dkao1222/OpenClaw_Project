# Gameplay Detail Spec

## 繁體中文

- 核心循環是開始短局、左右控制漂移、避開障礙、累積分數、碰撞失敗、立即重試。
- 分數由存活時間、近距離閃避與連續控制穩定度組成；失敗必須清楚指出碰撞或離線原因。
- 難度曲線以速度、障礙密度與視覺干擾逐步提高，但不得犧牲玩家對車體與障礙的可讀性。
- 系統契約必須保留 Control System、Speed System、Hazard System、Scoring System、Failure/Retry System、Feedback System；每個系統需要 input、state、rule、output、dependency 與 success/failure conditions。

## English

- The core loop is start run, steer drifting, avoid hazards, build score, fail on collision, and retry immediately.
- Score comes from survival time, near-miss avoidance, and control consistency; failure must clearly show collision or off-line cause.
- Difficulty scales through speed, hazard density, and visual pressure without sacrificing readability of the vehicle and hazards.
- The system contract must preserve Control System, Speed System, Hazard System, Scoring System, Failure/Retry System, and Feedback System; each system needs input, state, rule, output, dependency, and success/failure conditions.
