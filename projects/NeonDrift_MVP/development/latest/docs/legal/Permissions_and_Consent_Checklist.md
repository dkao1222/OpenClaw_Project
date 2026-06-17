# Permissions and Consent Checklist

## 繁體中文

- runtime permission: 不要求 location、camera、microphone、contacts、photos，除非功能明確需要且已更新 store disclosure。
- age gate: 若遊戲可能面向兒童或混合年齡層，必須在廣告與資料收集前處理年齡與區域限制。
- GDPR: EU / UK / EEA personalized ads 前必須取得有效 consent，拒絕時仍需提供非個人化廣告或無廣告 fallback。
- CCPA / US state privacy: 需要提供 opt-out / do-not-sell-or-share path，尤其是廣告資料 sharing。
- Apple ATT: iOS tracking 必須等 ATT authorization 後才能讀取 IDFA 或啟用 tracking SDK。
- Google Play: personal and sensitive user data 必須清楚揭露、合理使用、安全傳輸，不得販售。

## English

- runtime permission: do not request location, camera, microphone, contacts, or photos unless a feature clearly requires it and store disclosures are updated.
- age gate: if the game may target children or mixed audiences, age and regional restrictions must be handled before advertising and data collection.
- GDPR: EU / UK / EEA personalized ads require valid consent first; refusal must still provide non-personalized ads or an ad-free fallback.
- CCPA / US state privacy: provide opt-out / do-not-sell-or-share paths, especially for advertising data sharing.
- Apple ATT: iOS tracking must wait for ATT authorization before IDFA access or tracking SDK activation.
- Google Play: personal and sensitive user data must be clearly disclosed, reasonably used, securely transmitted, and not sold.